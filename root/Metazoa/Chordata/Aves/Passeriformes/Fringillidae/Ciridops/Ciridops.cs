using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Ciridops;

/// <summary>
/// Abstract class for Ciridops (genus).
/// NCBI TaxId: 3036776
/// </summary>
public abstract class Ciridops : Fringillidae, ICiridops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ciridops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3036776;

    /// <inheritdoc />
    public virtual string GenusName => "Ciridops";

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
