using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gehyra;

/// <summary>
/// Abstract class for Gehyra (genus).
/// NCBI TaxId: 95113
/// </summary>
public abstract class Gehyra : Gekkonidae, IGehyra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gehyra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 95113;

    /// <inheritdoc />
    public virtual string GenusName => "Gehyra";

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
