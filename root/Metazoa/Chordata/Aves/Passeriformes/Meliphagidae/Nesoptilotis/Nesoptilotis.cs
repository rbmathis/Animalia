using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Nesoptilotis;

/// <summary>
/// Abstract class for Nesoptilotis (genus).
/// NCBI TaxId: 1641794
/// </summary>
public abstract class Nesoptilotis : Meliphagidae, INesoptilotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesoptilotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1641794;

    /// <inheritdoc />
    public virtual string GenusName => "Nesoptilotis";

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
