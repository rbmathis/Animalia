using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Lophoictinia;

/// <summary>
/// Abstract class for Lophoictinia (genus).
/// NCBI TaxId: 321101
/// </summary>
public abstract class Lophoictinia : Accipitridae, ILophoictinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophoictinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321101;

    /// <inheritdoc />
    public virtual string GenusName => "Lophoictinia";

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
