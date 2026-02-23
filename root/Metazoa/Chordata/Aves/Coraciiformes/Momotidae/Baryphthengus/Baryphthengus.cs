using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae.Baryphthengus;

/// <summary>
/// Abstract class for Baryphthengus (genus).
/// NCBI TaxId: 135161
/// </summary>
public abstract class Baryphthengus : Momotidae, IBaryphthengus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Baryphthengus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135161;

    /// <inheritdoc />
    public virtual string GenusName => "Baryphthengus";

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
