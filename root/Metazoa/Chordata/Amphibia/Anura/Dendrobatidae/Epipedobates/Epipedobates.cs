using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Epipedobates;

/// <summary>
/// Abstract class for Epipedobates (genus).
/// NCBI TaxId: 92727
/// </summary>
public abstract class Epipedobates : Dendrobatidae, IEpipedobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epipedobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 92727;

    /// <inheritdoc />
    public virtual string GenusName => "Epipedobates";

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
