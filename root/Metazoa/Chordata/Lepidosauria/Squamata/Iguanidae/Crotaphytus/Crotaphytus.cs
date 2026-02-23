using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Crotaphytus;

/// <summary>
/// Abstract class for Crotaphytus (genus).
/// NCBI TaxId: 43590
/// </summary>
public abstract class Crotaphytus : Iguanidae, ICrotaphytus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crotaphytus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43590;

    /// <inheritdoc />
    public virtual string GenusName => "Crotaphytus";

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
