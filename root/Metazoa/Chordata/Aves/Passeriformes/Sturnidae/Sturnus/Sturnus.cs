using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Sturnus;

/// <summary>
/// Abstract class for Sturnus (genus).
/// NCBI TaxId: 9171
/// </summary>
public abstract class Sturnus : Sturnidae, ISturnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sturnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9171;

    /// <inheritdoc />
    public virtual string GenusName => "Sturnus";

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
