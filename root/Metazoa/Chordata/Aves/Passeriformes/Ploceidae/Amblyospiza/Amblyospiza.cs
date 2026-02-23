using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Amblyospiza;

/// <summary>
/// Abstract class for Amblyospiza (genus).
/// NCBI TaxId: 187414
/// </summary>
public abstract class Amblyospiza : Ploceidae, IAmblyospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblyospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187414;

    /// <inheritdoc />
    public virtual string GenusName => "Amblyospiza";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
