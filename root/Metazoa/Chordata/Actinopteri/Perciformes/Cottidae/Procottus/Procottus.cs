using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Procottus;

/// <summary>
/// Abstract class for Procottus (genus).
/// NCBI TaxId: 61630
/// </summary>
public abstract class Procottus : Cottidae, IProcottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Procottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61630;

    /// <inheritdoc />
    public virtual string GenusName => "Procottus";

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
