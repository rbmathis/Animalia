using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acrocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acrocephalidae.Calamonastides;

/// <summary>
/// Abstract class for Calamonastides (genus).
/// NCBI TaxId: 2821133
/// </summary>
public abstract class Calamonastides : Acrocephalidae, ICalamonastides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calamonastides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821133;

    /// <inheritdoc />
    public virtual string GenusName => "Calamonastides";

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
