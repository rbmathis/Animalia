using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Microcottus;

/// <summary>
/// Abstract class for Microcottus (genus).
/// NCBI TaxId: 274765
/// </summary>
public abstract class Microcottus : Cottidae, IMicrocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microcottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274765;

    /// <inheritdoc />
    public virtual string GenusName => "Microcottus";

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
