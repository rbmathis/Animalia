using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelus;

/// <summary>
/// Abstract class for Chelus (genus).
/// NCBI TaxId: 44494
/// </summary>
public abstract class Chelus : Chelidae, IChelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44494;

    /// <inheritdoc />
    public virtual string GenusName => "Chelus";

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
