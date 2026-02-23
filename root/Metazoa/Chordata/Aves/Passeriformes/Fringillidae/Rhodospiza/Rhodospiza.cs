using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Rhodospiza;

/// <summary>
/// Abstract class for Rhodospiza (genus).
/// NCBI TaxId: 589699
/// </summary>
public abstract class Rhodospiza : Fringillidae, IRhodospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhodospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589699;

    /// <inheritdoc />
    public virtual string GenusName => "Rhodospiza";

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
