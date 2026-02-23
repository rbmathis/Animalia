using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Anepischetosia;

/// <summary>
/// Abstract class for Anepischetosia (genus).
/// NCBI TaxId: 1336435
/// </summary>
public abstract class Anepischetosia : Scincidae, IAnepischetosia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anepischetosia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1336435;

    /// <inheritdoc />
    public virtual string GenusName => "Anepischetosia";

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
