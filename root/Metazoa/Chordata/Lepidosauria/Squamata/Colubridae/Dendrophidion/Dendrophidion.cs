using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dendrophidion;

/// <summary>
/// Abstract class for Dendrophidion (genus).
/// NCBI TaxId: 699575
/// </summary>
public abstract class Dendrophidion : Colubridae, IDendrophidion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrophidion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 699575;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrophidion";

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
