using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Burramyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Burramyidae.Cercartetus;

/// <summary>
/// Abstract class for Cercartetus (genus).
/// NCBI TaxId: 38601
/// </summary>
public abstract class Cercartetus : Burramyidae, ICercartetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cercartetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38601;

    /// <inheritdoc />
    public virtual string GenusName => "Cercartetus";

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
