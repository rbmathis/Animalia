using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Mergus;

/// <summary>
/// Abstract class for Mergus (genus).
/// NCBI TaxId: 8877
/// </summary>
public abstract class Mergus : Anatidae, IMergus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mergus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8877;

    /// <inheritdoc />
    public virtual string GenusName => "Mergus";

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
