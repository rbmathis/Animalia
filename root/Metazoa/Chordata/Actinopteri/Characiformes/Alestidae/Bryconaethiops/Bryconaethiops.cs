using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Bryconaethiops;

/// <summary>
/// Abstract class for Bryconaethiops (genus).
/// NCBI TaxId: 206449
/// </summary>
public abstract class Bryconaethiops : Alestidae, IBryconaethiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bryconaethiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206449;

    /// <inheritdoc />
    public virtual string GenusName => "Bryconaethiops";

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
