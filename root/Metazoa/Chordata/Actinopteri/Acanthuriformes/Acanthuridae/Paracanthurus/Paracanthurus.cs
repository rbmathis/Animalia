using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Paracanthurus;

/// <summary>
/// Abstract class for Paracanthurus (genus).
/// NCBI TaxId: 75029
/// </summary>
public abstract class Paracanthurus : Acanthuridae, IParacanthurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracanthurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75029;

    /// <inheritdoc />
    public virtual string GenusName => "Paracanthurus";

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
