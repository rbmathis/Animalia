using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Dixonius;

/// <summary>
/// Abstract class for Dixonius (genus).
/// NCBI TaxId: 476470
/// </summary>
public abstract class Dixonius : Gekkonidae, IDixonius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dixonius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 476470;

    /// <inheritdoc />
    public virtual string GenusName => "Dixonius";

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
