using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae.Momotus;

/// <summary>
/// Abstract class for Momotus (genus).
/// NCBI TaxId: 57424
/// </summary>
public abstract class Momotus : Momotidae, IMomotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Momotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57424;

    /// <inheritdoc />
    public virtual string GenusName => "Momotus";

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
