using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Acanthocharax;

/// <summary>
/// Abstract class for Acanthocharax (genus).
/// NCBI TaxId: 2914953
/// </summary>
public abstract class Acanthocharax : Characidae, IAcanthocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2914953;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthocharax";

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
