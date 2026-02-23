using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Taudactylus;

/// <summary>
/// Abstract class for Taudactylus (genus).
/// NCBI TaxId: 377265
/// </summary>
public abstract class Taudactylus : Myobatrachidae, ITaudactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taudactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 377265;

    /// <inheritdoc />
    public virtual string GenusName => "Taudactylus";

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
