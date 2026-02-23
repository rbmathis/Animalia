using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Tubulidentata.Orycteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Tubulidentata.Orycteropodidae.Orycteropus;

/// <summary>
/// Abstract class for Orycteropus (genus).
/// NCBI TaxId: 9817
/// </summary>
public abstract class Orycteropus : Orycteropodidae, IOrycteropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orycteropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9817;

    /// <inheritdoc />
    public virtual string GenusName => "Orycteropus";

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
