using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Hara;

/// <summary>
/// Abstract class for Hara (genus).
/// NCBI TaxId: 385297
/// </summary>
public abstract class Hara : Sisoridae, IHara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385297;

    /// <inheritdoc />
    public virtual string GenusName => "Hara";

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
