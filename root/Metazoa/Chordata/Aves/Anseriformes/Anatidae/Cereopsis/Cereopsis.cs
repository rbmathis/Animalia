using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cereopsis;

/// <summary>
/// Abstract class for Cereopsis (genus).
/// NCBI TaxId: 8857
/// </summary>
public abstract class Cereopsis : Anatidae, ICereopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cereopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8857;

    /// <inheritdoc />
    public virtual string GenusName => "Cereopsis";

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
