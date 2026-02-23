using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Necrosyrtes;

/// <summary>
/// Abstract class for Necrosyrtes (genus).
/// NCBI TaxId: 30398
/// </summary>
public abstract class Necrosyrtes : Accipitridae, INecrosyrtes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Necrosyrtes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30398;

    /// <inheritdoc />
    public virtual string GenusName => "Necrosyrtes";

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
