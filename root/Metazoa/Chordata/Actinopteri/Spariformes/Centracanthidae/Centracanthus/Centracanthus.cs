using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Centracanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Centracanthidae.Centracanthus;

/// <summary>
/// Abstract class for Centracanthus (genus).
/// NCBI TaxId: 490315
/// </summary>
public abstract class Centracanthus : Centracanthidae, ICentracanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centracanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490315;

    /// <inheritdoc />
    public virtual string GenusName => "Centracanthus";

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
