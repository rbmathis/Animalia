using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Aquila;

/// <summary>
/// Abstract class for Aquila (genus).
/// NCBI TaxId: 8960
/// </summary>
public abstract class Aquila : Accipitridae, IAquila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aquila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8960;

    /// <inheritdoc />
    public virtual string GenusName => "Aquila";

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
