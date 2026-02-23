using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Achoerodus;

/// <summary>
/// Abstract class for Achoerodus (genus).
/// NCBI TaxId: 241260
/// </summary>
public abstract class Achoerodus : Labridae, IAchoerodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Achoerodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241260;

    /// <inheritdoc />
    public virtual string GenusName => "Achoerodus";

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
