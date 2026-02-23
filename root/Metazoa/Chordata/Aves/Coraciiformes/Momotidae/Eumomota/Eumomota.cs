using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae.Eumomota;

/// <summary>
/// Abstract class for Eumomota (genus).
/// NCBI TaxId: 1271782
/// </summary>
public abstract class Eumomota : Momotidae, IEumomota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eumomota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1271782;

    /// <inheritdoc />
    public virtual string GenusName => "Eumomota";

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
