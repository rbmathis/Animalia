using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae.Aspatha;

/// <summary>
/// Abstract class for Aspatha (genus).
/// NCBI TaxId: 2231439
/// </summary>
public abstract class Aspatha : Momotidae, IAspatha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspatha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2231439;

    /// <inheritdoc />
    public virtual string GenusName => "Aspatha";

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
