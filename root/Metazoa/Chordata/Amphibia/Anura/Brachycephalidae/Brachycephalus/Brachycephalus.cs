using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brachycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brachycephalidae.Brachycephalus;

/// <summary>
/// Abstract class for Brachycephalus (genus).
/// NCBI TaxId: 164301
/// </summary>
public abstract class Brachycephalus : Brachycephalidae, IBrachycephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachycephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164301;

    /// <inheritdoc />
    public virtual string GenusName => "Brachycephalus";

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
