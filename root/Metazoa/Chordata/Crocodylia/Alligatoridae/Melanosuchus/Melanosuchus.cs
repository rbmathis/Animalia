using AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Melanosuchus;

/// <summary>
/// Abstract class for Melanosuchus (genus).
/// NCBI TaxId: 38655
/// </summary>
public abstract class Melanosuchus : Alligatoridae, IMelanosuchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanosuchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38655;

    /// <inheritdoc />
    public virtual string GenusName => "Melanosuchus";

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
