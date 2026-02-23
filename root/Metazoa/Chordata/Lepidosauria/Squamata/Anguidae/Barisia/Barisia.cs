using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Barisia;

/// <summary>
/// Abstract class for Barisia (genus).
/// NCBI TaxId: 76651
/// </summary>
public abstract class Barisia : Anguidae, IBarisia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barisia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76651;

    /// <inheritdoc />
    public virtual string GenusName => "Barisia";

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
