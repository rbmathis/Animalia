using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Carpospiza;

/// <summary>
/// Abstract class for Carpospiza (genus).
/// NCBI TaxId: 589652
/// </summary>
public abstract class Carpospiza : Passeridae, ICarpospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carpospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589652;

    /// <inheritdoc />
    public virtual string GenusName => "Carpospiza";

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
