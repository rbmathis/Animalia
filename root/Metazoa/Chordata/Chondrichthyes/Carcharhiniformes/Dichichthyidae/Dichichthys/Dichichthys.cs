using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Dichichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Dichichthyidae.Dichichthys;

/// <summary>
/// Abstract class for Dichichthys (genus).
/// NCBI TaxId: 3241163
/// </summary>
public abstract class Dichichthys : Dichichthyidae, IDichichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dichichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3241163;

    /// <inheritdoc />
    public virtual string GenusName => "Dichichthys";

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
