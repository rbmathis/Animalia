using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Japonoconger;

/// <summary>
/// Abstract class for Japonoconger (genus).
/// NCBI TaxId: 3093622
/// </summary>
public abstract class Japonoconger : Congridae, IJaponoconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Japonoconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3093622;

    /// <inheritdoc />
    public virtual string GenusName => "Japonoconger";

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
