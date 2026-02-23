using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Chelictinia;

/// <summary>
/// Abstract class for Chelictinia (genus).
/// NCBI TaxId: 2763547
/// </summary>
public abstract class Chelictinia : Accipitridae, IChelictinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelictinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2763547;

    /// <inheritdoc />
    public virtual string GenusName => "Chelictinia";

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
