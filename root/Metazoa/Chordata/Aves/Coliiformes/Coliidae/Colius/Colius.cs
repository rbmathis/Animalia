using AnimalKingdom.root.Metazoa.Chordata.Aves.Coliiformes.Coliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coliiformes.Coliidae.Colius;

/// <summary>
/// Abstract class for Colius (genus).
/// NCBI TaxId: 57409
/// </summary>
public abstract class Colius : Coliidae, IColius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57409;

    /// <inheritdoc />
    public virtual string GenusName => "Colius";

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
