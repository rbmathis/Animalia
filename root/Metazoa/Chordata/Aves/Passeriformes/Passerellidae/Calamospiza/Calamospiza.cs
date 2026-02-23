using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Calamospiza;

/// <summary>
/// Abstract class for Calamospiza (genus).
/// NCBI TaxId: 194937
/// </summary>
public abstract class Calamospiza : Passerellidae, ICalamospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calamospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 194937;

    /// <inheritdoc />
    public virtual string GenusName => "Calamospiza";

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
