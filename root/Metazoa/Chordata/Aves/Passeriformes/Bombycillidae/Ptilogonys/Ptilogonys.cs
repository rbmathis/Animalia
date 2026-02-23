using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bombycillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bombycillidae.Ptilogonys;

/// <summary>
/// Abstract class for Ptilogonys (genus).
/// NCBI TaxId: 254653
/// </summary>
public abstract class Ptilogonys : Bombycillidae, IPtilogonys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptilogonys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254653;

    /// <inheritdoc />
    public virtual string GenusName => "Ptilogonys";

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
