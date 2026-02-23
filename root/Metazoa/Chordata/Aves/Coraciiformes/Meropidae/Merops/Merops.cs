using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Meropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Meropidae.Merops;

/// <summary>
/// Abstract class for Merops (genus).
/// NCBI TaxId: 57420
/// </summary>
public abstract class Merops : Meropidae, IMerops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Merops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57420;

    /// <inheritdoc />
    public virtual string GenusName => "Merops";

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
