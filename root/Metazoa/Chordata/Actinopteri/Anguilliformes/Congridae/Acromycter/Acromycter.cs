using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Acromycter;

/// <summary>
/// Abstract class for Acromycter (genus).
/// NCBI TaxId: 1642171
/// </summary>
public abstract class Acromycter : Congridae, IAcromycter
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acromycter";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1642171;

    /// <inheritdoc />
    public virtual string GenusName => "Acromycter";

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
