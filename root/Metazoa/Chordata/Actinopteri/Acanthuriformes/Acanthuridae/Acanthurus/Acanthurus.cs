using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Acanthurus;

/// <summary>
/// Abstract class for Acanthurus (genus).
/// NCBI TaxId: 12912
/// </summary>
public abstract class Acanthurus : Acanthuridae, IAcanthurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 12912;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthurus";

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
