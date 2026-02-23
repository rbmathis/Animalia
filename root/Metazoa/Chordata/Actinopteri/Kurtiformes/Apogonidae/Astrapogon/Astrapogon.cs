using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Astrapogon;

/// <summary>
/// Abstract class for Astrapogon (genus).
/// NCBI TaxId: 588209
/// </summary>
public abstract class Astrapogon : Apogonidae, IAstrapogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astrapogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 588209;

    /// <inheritdoc />
    public virtual string GenusName => "Astrapogon";

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
