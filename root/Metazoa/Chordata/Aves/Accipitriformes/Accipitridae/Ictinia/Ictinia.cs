using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Ictinia;

/// <summary>
/// Abstract class for Ictinia (genus).
/// NCBI TaxId: 321099
/// </summary>
public abstract class Ictinia : Accipitridae, IIctinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ictinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321099;

    /// <inheritdoc />
    public virtual string GenusName => "Ictinia";

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
