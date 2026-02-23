using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae.Acropoma;

/// <summary>
/// Abstract class for Acropoma (genus).
/// NCBI TaxId: 223792
/// </summary>
public abstract class Acropoma : Acropomatidae, IAcropoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acropoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223792;

    /// <inheritdoc />
    public virtual string GenusName => "Acropoma";

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
