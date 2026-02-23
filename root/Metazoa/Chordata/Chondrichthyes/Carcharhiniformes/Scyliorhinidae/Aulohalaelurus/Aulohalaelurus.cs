using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Aulohalaelurus;

/// <summary>
/// Abstract class for Aulohalaelurus (genus).
/// NCBI TaxId: 496085
/// </summary>
public abstract class Aulohalaelurus : Scyliorhinidae, IAulohalaelurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aulohalaelurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 496085;

    /// <inheritdoc />
    public virtual string GenusName => "Aulohalaelurus";

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
