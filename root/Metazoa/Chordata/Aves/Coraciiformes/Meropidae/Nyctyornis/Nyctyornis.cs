using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Meropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Meropidae.Nyctyornis;

/// <summary>
/// Abstract class for Nyctyornis (genus).
/// NCBI TaxId: 457350
/// </summary>
public abstract class Nyctyornis : Meropidae, INyctyornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctyornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 457350;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctyornis";

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
