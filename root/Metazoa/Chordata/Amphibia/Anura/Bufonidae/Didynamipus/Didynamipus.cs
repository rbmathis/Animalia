using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Didynamipus;

/// <summary>
/// Abstract class for Didynamipus (genus).
/// NCBI TaxId: 120966
/// </summary>
public abstract class Didynamipus : Bufonidae, IDidynamipus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Didynamipus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 120966;

    /// <inheritdoc />
    public virtual string GenusName => "Didynamipus";

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
