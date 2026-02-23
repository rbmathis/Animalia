using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Careproctus;

/// <summary>
/// Abstract class for Careproctus (genus).
/// NCBI TaxId: 274784
/// </summary>
public abstract class Careproctus : Liparidae, ICareproctus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Careproctus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274784;

    /// <inheritdoc />
    public virtual string GenusName => "Careproctus";

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
