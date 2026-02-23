using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Phrynoglossus;

/// <summary>
/// Abstract class for Phrynoglossus (genus).
/// NCBI TaxId: 2798810
/// </summary>
public abstract class Phrynoglossus : Dicroglossidae, IPhrynoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2798810;

    /// <inheritdoc />
    public virtual string GenusName => "Phrynoglossus";

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
