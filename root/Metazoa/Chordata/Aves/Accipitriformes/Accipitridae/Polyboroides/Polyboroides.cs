using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Polyboroides;

/// <summary>
/// Abstract class for Polyboroides (genus).
/// NCBI TaxId: 8972
/// </summary>
public abstract class Polyboroides : Accipitridae, IPolyboroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polyboroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8972;

    /// <inheritdoc />
    public virtual string GenusName => "Polyboroides";

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
