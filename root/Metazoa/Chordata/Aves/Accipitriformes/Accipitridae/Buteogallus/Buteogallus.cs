using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Buteogallus;

/// <summary>
/// Abstract class for Buteogallus (genus).
/// NCBI TaxId: 223495
/// </summary>
public abstract class Buteogallus : Accipitridae, IButeogallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Buteogallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223495;

    /// <inheritdoc />
    public virtual string GenusName => "Buteogallus";

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
