using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Contomastix;

/// <summary>
/// Abstract class for Contomastix (genus).
/// NCBI TaxId: 1392235
/// </summary>
public abstract class Contomastix : Teiidae, IContomastix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Contomastix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1392235;

    /// <inheritdoc />
    public virtual string GenusName => "Contomastix";

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
