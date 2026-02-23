using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Micronisus;

/// <summary>
/// Abstract class for Micronisus (genus).
/// NCBI TaxId: 387844
/// </summary>
public abstract class Micronisus : Accipitridae, IMicronisus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micronisus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 387844;

    /// <inheritdoc />
    public virtual string GenusName => "Micronisus";

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
