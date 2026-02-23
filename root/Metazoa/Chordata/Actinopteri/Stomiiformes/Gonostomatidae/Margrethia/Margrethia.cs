using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.Margrethia;

/// <summary>
/// Abstract class for Margrethia (genus).
/// NCBI TaxId: 48458
/// </summary>
public abstract class Margrethia : Gonostomatidae, IMargrethia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Margrethia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48458;

    /// <inheritdoc />
    public virtual string GenusName => "Margrethia";

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
