using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Ficimia;

/// <summary>
/// Abstract class for Ficimia (genus).
/// NCBI TaxId: 703961
/// </summary>
public abstract class Ficimia : Colubridae, IFicimia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ficimia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 703961;

    /// <inheritdoc />
    public virtual string GenusName => "Ficimia";

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
