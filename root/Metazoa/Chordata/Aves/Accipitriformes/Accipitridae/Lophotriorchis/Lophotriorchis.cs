using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Lophotriorchis;

/// <summary>
/// Abstract class for Lophotriorchis (genus).
/// NCBI TaxId: 2677970
/// </summary>
public abstract class Lophotriorchis : Accipitridae, ILophotriorchis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophotriorchis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677970;

    /// <inheritdoc />
    public virtual string GenusName => "Lophotriorchis";

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
