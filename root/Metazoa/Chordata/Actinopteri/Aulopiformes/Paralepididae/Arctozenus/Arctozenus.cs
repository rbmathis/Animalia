using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Arctozenus;

/// <summary>
/// Abstract class for Arctozenus (genus).
/// NCBI TaxId: 473347
/// </summary>
public abstract class Arctozenus : Paralepididae, IArctozenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arctozenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473347;

    /// <inheritdoc />
    public virtual string GenusName => "Arctozenus";

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
