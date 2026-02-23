using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Pithecophaga;

/// <summary>
/// Abstract class for Pithecophaga (genus).
/// NCBI TaxId: 321088
/// </summary>
public abstract class Pithecophaga : Accipitridae, IPithecophaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pithecophaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321088;

    /// <inheritdoc />
    public virtual string GenusName => "Pithecophaga";

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
